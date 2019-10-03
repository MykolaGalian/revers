namespace revers_arr_
{
    public class Node
    {
        public  Node Next; 
        public string Item;

        public Node(string data) {
            Next = null;
            Item = data;
        }
    }
}