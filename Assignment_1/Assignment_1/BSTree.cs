// File: BTree.cs
// An implementation of BTree ADT
// Maolin Tang 
// 24/3/06

using System;
namespace Assignment_1
{
	 class BTreeNode
	{
		private Member member; // value
		private BTreeNode lchild; // reference to its left child 
		private BTreeNode rchild; // reference to its right child

		public BTreeNode(Member member)
		{
			this.member = member;
			lchild = null;
			rchild = null;
		}

		public Member Member
		{
			get { return member; }
			set { member = value; }
		}

		public BTreeNode LChild
		{
			get { return lchild; }
			set { lchild = value; }
		}

		public BTreeNode RChild
		{
			get { return rchild; }
			set { rchild = value; }
		}
	}

}




