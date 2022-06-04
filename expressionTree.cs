// using System;
// using System.Collections.Generic;


// class Node{
// 	public char data;
// 	public Node left,right;
// 	public Node(char data){
// 		this.data = data;
// 		left = right = null;
// 	}
// }

// public class GFG {
// 	public static bool isOperator(char ch){
// 		if(ch=='+' || ch=='-'|| ch=='*' || ch=='/' || ch=='^'){
// 			return true;
// 		}
// 		return false;
// 	}
// 	static Node expressionTree(String postfix){
// 		Stack<Node> st = new Stack<Node>();
// 		Node t1, t2, temp;

// 		for(int i = 0; i < postfix.Length; i++)
// 		{
// 			if(!isOperator(postfix[i])){
// 				temp = new Node(postfix[i]);
// 				st.Push(temp);
// 			}
// 			else{
// 				temp = new Node(postfix[i]);

// 				t1 = st.Pop();
// 				t2 = st.Pop();

// 				temp.left = t2;
// 				temp.right = t1;

// 				st.Push(temp);
// 			}

// 		}
// 		temp = st.Pop();
// 		return temp;
// 	}
// 	static void inorder(Node root){
// 		if(root == null) return;

// 		inorder(root.left);
// 		Console.Write(root.data);
// 		inorder(root.right);
// 	}
// 	public static void Main(String[] args)
// 	{
// 		String postfix = "ABC*+D/";

// 		Node r = expressionTree(postfix);
// 		inorder(r);
// 	}
// }

// // This code is contributed by 29AjayKumar
