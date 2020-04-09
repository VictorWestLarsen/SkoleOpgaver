1.
Func<int, int, int> myFunc = (x,y) => x+y;

2.
Func<int, int> myFunc = x =>
        {
            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                result += x;
            }
            return result;
        };

3. 
Func<int, int> myFunc = x => x * x;