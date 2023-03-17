namespace DictonaryDemo;
class Program
{
    static void Main(string[] args)
    {
        MyDictonary<string, string> myDictonary = new MyDictonary<string, string>();
        myDictonary.Add("Name", "Omer");
        myDictonary.Add("Surname", "Sert");
        myDictonary.Add("University", "Istanbul University");

    }


    class MyDictonary<T1, T2>
    {
        T1[] items1;
        T2[] items2;
        T1[] _tempArray1;
        T2[] _tempArray2;

        public MyDictonary()
        {
            items1 = new T1[0];
            items2 = new T2[0];
        }

        public void Add(T1 item1, T2 item2)
        {
            _tempArray1 = items1;
            _tempArray2 = items2;
            items1 = new T1[items1.Length + 1];
            items2 = new T2[items2.Length + 1];
            for (int i = 0; i < _tempArray1.Length; i++)
            {
                items1[i] = _tempArray1[i];
            }
            for (int i = 0; i < _tempArray2.Length; i++)
            {
                items2[i] = _tempArray2[i];
            }
            items1[items1.Length - 1] = item1;
            items2[items2.Length - 1] = item2;
        }
    }

}

