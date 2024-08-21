namespace Task_IndexerDataStructure
{
    class IntArray
    {
        private int[] array;
        private static int ArraySize { get; set; } = 0;


        public int this[int i]
        {
            get 
            { 
                return array[i]; 
            } 
            set 
            {
                array[i] = value; 
            }
        }

        public void Add(int number)
        {
            Array.Resize(ref array, ++ArraySize);
            array[array.Length - 1] = number;
        }


        public void Add(params int[] numbers)
        {
            ArraySize += numbers.Length;
            Array.Resize(ref array, ArraySize);
            Array.Copy(numbers, 0, array, array.Length - numbers.Length, numbers.Length);
            
        }


        public void Contains(int number)
        {
            if (array.Contains(number))
            {
                Console.WriteLine($"Array contain number {number}");
            }
            else
            {
                Console.WriteLine($"Array doesn't contain number {number}");
            }
        }


        public void Pop()
        {
            var lastElement = $"Last element of array be: {array[array.Length - 1]}";
            array = array.Where(x => x != array[array.Length-1]).ToArray();
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(lastElement);
        }


        public void Sum()
        {
            Console.WriteLine(array.Sum());
        }

        public void ToString()
        {
            string result = "";
            foreach (var number in array)
            {
                result += number;
            }
            Console.WriteLine(result);
        }

        public void ShowArray()
        {
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
