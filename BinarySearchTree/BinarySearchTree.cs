public class Node 
{
    public Node? LeftNode { get; set; }
    public Node? RightNode { get; set; }
    public int Data { get; set; }
}

public class BinaryTree
{
    public Node? Root { get; set; }

    public bool Add(int value)
    {
        Node? before = null;
        var after = Root;

        while (after != null)
        {
            before = after;
            if (value < after.Data)
            {
                after = after.LeftNode;
            }
            else if (value > after.Data)
            {
                after = after.RightNode;
            }
            else
            {
                return false;
            }
        }

        var newNode = new Node
        {
            Data = value
        };

        if (Root == null)
        {
            Root = newNode;
        }
        else
        {
            if (before is not null 
                && value < before.Data)
            {
                before.LeftNode = newNode;
            }
            else if (before is not null)
            {
                before.RightNode = newNode;
            }
        }

        return true;
    }

    public void Remove(int value)
    {
        Root = Remove(Root, value);
    }

    private Node? Remove(Node? parent, int key)
    {
        if (parent is null)
        {
            return parent;
        }

        if (key < parent.Data)
        {
            parent.LeftNode = Remove(parent.LeftNode, key);
        }
        else if (key > parent.Data)
        {
            parent.RightNode = Remove(parent.RightNode, key);
        }
        else
        {
            if (parent.LeftNode == null)
            {
                return parent.RightNode;
            }

            if (parent.RightNode == null)
            {
                return parent.LeftNode;
            }

            parent.Data = MinValue(parent.RightNode);
            parent.RightNode = Remove(parent.RightNode, parent.Data);
        }

        return parent;
    }

    private int MinValue(Node node)
    {
        var minV = node.Data;
        while (node.LeftNode != null)
        {
            minV = node.LeftNode.Data;
            node = node.LeftNode;
        }

        return minV;
    }
    

    public Node? Find(int value)
    {
        return Find(value, this.Root);
    }

    private Node? Find(int value, Node? parent)
    {
        if (parent is not null)
        {
            return value == parent.Data 
                ? parent 
                : Find(value, value < parent.Data 
                    ? parent.LeftNode
                    : parent.RightNode);
        }

        return null;
    }

    public int GetTreeDepth()
    {
        return GetTreeDepth(Root);
    }

    private int GetTreeDepth(Node? parent)
    {
        return parent is null 
            ? 0 
            : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
    }

    public void TraversePreOrder(Node? parent)
    {
        if (parent is null)
        {
            return;
        }
        
        TraversePreOrder(parent.LeftNode);
        TraversePreOrder(parent.RightNode);
    }

    public void TraversePostOrder(Node? parent)
    {
        if (parent is null)
        {
            return;
        }
        
        TraversePostOrder(parent.LeftNode);
        TraversePostOrder(parent.RightNode);
    }
}