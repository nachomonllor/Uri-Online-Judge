 https://www.codewars.com/kata/56f7493f5d7c12d1690000b6/solutions/csharp

public static object[] Mean(char[] lst)
        {

            double sum = 0.0;
            string concat = "";
            for (int i = 0; i < lst.Length; i++)
            {
                if (lst[i] >= '0' && lst[i] <= '9')
                {
                    sum += lst[i] - '0';
                }
                else
                {
                    concat += lst[i];
                }
            }
            return new object[] {sum/10.0, concat };
        }
