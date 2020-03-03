  https://www.codewars.com/kata/calculate-string-rotation/csharp

public static int ShiftedDiff(string first, string second)
        {
            if (first.Length != second.Length) return -1;
            string concat = second + second;
            return concat.IndexOf(first);
        }