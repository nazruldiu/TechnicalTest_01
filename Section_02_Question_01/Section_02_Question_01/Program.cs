using System;

namespace Section_02_Question_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void myFunction(int[] A, int L, int R)
        {
            int I, J, P, T;

            for(int i=0; i<=A.Length; i++)
            {
                I = L; J = R;
                //P:= A[(L + R) shr 1];
                P = A[L + R - 1];
                //while A[I] < P
                while (A[I] < P)
                {
                    //Inc(I);
                }

                //while A[J] > P
                while (A[J] < P)
                {
                    //Dec(J);
                }

                //if I <= J then
                //begin
                //T:= A[I];
                //A[I] := A[J];
                //A[J] := T;
                //Inc(I);
                //Dec(J);
                //end;
                //until I > J;
                //if L < J then
                //f(A, L, J);
                //  L:= I;
                //until I >= R;

                if (I <= J)
                {
                    T = A[I];
                    A[I] = A[J];
                    A[J] = T;
                }

                if(L < J)
                {
                    myFunction(A, L, J);
                    L = I;
                }
            }
        }
    }
}
