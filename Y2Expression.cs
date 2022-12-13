
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace doancuoiki
{
    public class Y2Expression
    {

        public static string Infix2Prefix(string infix)
        {
            List<string> prefix = new List<string>();
            Stack<string> stack = new Stack<string>();

            FormatExpression(ref infix);

            IEnumerable<string> enumer = infix.Split(' ').Reverse();// .Where(s => !String.IsNullOrEmpty(s));

            foreach (string s in enumer)
            {
                if (IsOperand(s))
                    prefix.Add(s);
                else if (s == ")")
                    stack.Push(s);
                else if (s == "(")
                {
                    string x = stack.Pop();
                    while (x != ")")
                    {
                        prefix.Add(x);
                        x = stack.Pop();
                    }
                }
                else// if (IsOperator(s))
                {
                    while (stack.Count > 0 && GetPriority(s) < GetPriority(stack.Peek()))
                        prefix.Add(stack.Pop());
                    stack.Push(s);
                }
            }

            while (stack.Count > 0)
                prefix.Add(stack.Pop());

            StringBuilder str = new StringBuilder();
            for (int i = prefix.Count - 1; i >= 0; i--)
            {
                str.Append(prefix[i]).Append(" ");
            }

            return str.ToString();
        }

        public static string Infix2Postfix(string infix)
        {
            FormatExpression(ref infix);

            IEnumerable<string> str = infix.Split(' ');
            Stack<string> stack = new Stack<string>();
            StringBuilder postfix = new StringBuilder();

            foreach (string s in str)
            {
                if (IsOperand(s))
                    postfix.Append(s).Append(" ");
                else if (s == "(")
                    stack.Push(s);
                else if (s == ")")
                {
                    string x = stack.Pop();
                    while (x != "(")
                    {
                        postfix.Append(x).Append(" ");
                        x = stack.Pop();
                    }
                }
                else// (IsOperator(s))
                {
                    while (stack.Count > 0 && GetPriority(s) <= GetPriority(stack.Peek()))
                        postfix.Append(stack.Pop()).Append(" ");
                    stack.Push(s);
                }
            }

            while (stack.Count > 0)
                postfix.Append(stack.Pop()).Append(" ");

            return postfix.ToString();
        }

        /// <summary>
        /// Tạo một cây nhị phân 3 node với node gốc là toán tử, 2 node lá là toán hạng
        /// </summary>
        /// <param name="node"></param>
        /// <param name="opStack"></param>
        /// <param name="nodeStack"></param>
        private static void CreateSubTree(Stack<BinaryTreeNode> opStack, Stack<BinaryTreeNode> nodeStack)
        {
            BinaryTreeNode node = opStack.Pop();
            node.RightChild = nodeStack.Pop();
            node.LeftChild = nodeStack.Pop();
            nodeStack.Push(node);
        }

        public static BinaryTreeNode Infix2ExpressionTree(string infixExpression)
        {
            List<string> prefix = new List<string>();
            Stack<BinaryTreeNode> operatorStack = new Stack<BinaryTreeNode>();
            Stack<BinaryTreeNode> nodeStack = new Stack<BinaryTreeNode>();

            FormatExpression(ref infixExpression);

            IEnumerable<string> enumer = infixExpression.Split(' ');

            foreach (string s in enumer)
            {
                if (IsOperand(s))
                    nodeStack.Push(new BinaryTreeNode(s));
                else if (s == "(")
                    operatorStack.Push(new BinaryTreeNode(s));
                else if (s == ")")
                {
                    while (operatorStack.Peek().Value != "(")
                        CreateSubTree(operatorStack, nodeStack);
                    operatorStack.Pop();
                }
                else if (IsOperator(s))
                {
                    while (operatorStack.Count > 0 && GetPriority(operatorStack.Peek().Value) >= GetPriority(s))
                        CreateSubTree(operatorStack, nodeStack);

                    operatorStack.Push(new BinaryTreeNode(s));
                }

            }

            while (operatorStack.Count > 0)
                CreateSubTree(operatorStack, nodeStack);

            return nodeStack.Peek();
        }

        public static BinaryTreeNode Postfix2ExpressionTree(string postfixExpression)
        {
            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();

            IEnumerable<string> enumer = postfixExpression.Split(' ');

            foreach (string s in enumer)
            {
                BinaryTreeNode node = new BinaryTreeNode(s);
                if (IsOperand(s))
                    stack.Push(node);
                else if (IsOperator(s))
                {
                    node.RightChild = stack.Pop();
                    node.LeftChild = stack.Pop();
                    stack.Push(node);
                }
            }
            return stack.Pop();
        }

        public static void FormatExpression(ref string expression)
        {
            expression = expression.Replace(" ", "");

            expression = Regex.Replace(expression, @"\+|\-|\*|\/|\%|\)|\(", match =>
                String.Format(" {0} ", match.Value)
            );
            expression = expression.Replace("  ", " ");
            expression = expression.Trim();
        }

        public static int GetPriority(string op)
        {
            if (op == "*" || op == "/" || op == "%")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }

        private static bool IsOperator(string str)
        {
            return Regex.Match(str, @"\+|\-|\*|\/|\%").Success;
        }

        public static bool IsOperand(string str)
        {
            return Regex.Match(str, @"^\d+$|^([a-z]|[A-Z])$").Success;
        }

        public static float EvaluatePostfix(string postfix)
        {
            Stack<float> stack = new Stack<float>();
            postfix = postfix.Trim();

            IEnumerable<string> enumer = postfix.Split(' ');

            foreach (string s in enumer)
            {
                if (IsOperand(s))
                    stack.Push(float.Parse(s));
                else
                {
                    float x = stack.Pop();
                    float y = stack.Pop();

                    switch (s)
                    {
                        case "+": y += x; break;
                        case "-": y -= x; break;
                        case "*": y *= x; break;
                        case "/": y /= x; break;
                        case "%": y %= x; break;
                    }
                    stack.Push(y);
                }
            }
            return stack.Pop();
        }

        public static float EvaluatePrefix(string prefix)
        {
            Stack<float> stack = new Stack<float>();
            prefix = prefix.Trim();

            IEnumerable<string> enumer = prefix.Split(' ').Reverse();

            foreach (string s in enumer)
            {
                if (IsOperand(s))
                    stack.Push(float.Parse(s));
                else
                {
                    float y = stack.Pop();
                    float x = stack.Pop();

                    switch (s)
                    {
                        case "+": y += x; break;
                        case "-": y -= x; break;
                        case "*": y *= x; break;
                        case "/": y /= x; break;
                        case "%": y %= x; break;
                    }
                    stack.Push(y);
                }
            }
            return stack.Pop();
        }
        public static float EvaluateExpressionTree(BinaryTreeNode node)
        {
            float t = 0;
            if (node.IsLeaf)
                t = float.Parse(node.Value);
            else
            {
                float x = EvaluateExpressionTree(node.LeftChild);
                float y = EvaluateExpressionTree(node.RightChild);

                switch (node.Value)
                {
                    case "+": t = x + y; break;
                    case "-": t = x - y; break;
                    case "*": t = x * y; break;
                    case "/": t = x / y; break;
                    case "%": t = x % y; break;
                }
            }
            return t;
        }
    }
}

