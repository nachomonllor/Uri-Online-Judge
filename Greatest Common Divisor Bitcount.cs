https://www.codewars.com/kata/54b45c37041df0caf800020f/solutions/csharp

static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        } 

        public static int GcdBinary(int x, int y)
        {
            int g = gcd(x, y);
            int cont = 0;
            while (g != 0)
            {
                if (g % 2 == 1 || g%2 == -1) cont++;
                g /= 2;
            }
            return cont;
        }