using System;

namespace Section_02_Question_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4};

            myFunction(arr, 0, 2);
        }

        static void myFunction(int[] A, int L, int R)
        {
            int I, J, P, T;
            do{
                I = L; J = R;
                //P:= A[(L + R) shr 1];
                P = A[L + R + 1];
                do
                {
                    //while A[I] < P
                    while (A[I] < P)
                    {
                        //Inc(I);
                        I = I + 1;
                    }
                    //while A[J] > P
                    while (A[J] > P)
                    {
                        //Dec(J);
                        J = J - 1;
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
                        I = I + 1;
                        J = J - 1;
                    }
                } while (I <= J);

                if (L < J)
                {
                    myFunction(A, L, J);
                }
                L = I;
            }while (I < R) ;
        }
    }
}
