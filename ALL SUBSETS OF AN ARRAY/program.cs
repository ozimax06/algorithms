//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
   public class Program {

	static int[] B = { 1, 2, 3, 4, 5 };
       
    public static void Main(String[] args) {
		Program a = new Program();
		int[] A = new int[B.Count()];
		a.combinations(A, 0);

	}


	//x ==> index.
	//exp if index = 2 then ==> {Empty} {5}  {4}  {45}  {3}  {35}  {34}  {345}  
	public void combinations(int[] A, int x) {
		if (x == A.Count() - 1) {
			A[x] = 0; // last digit, don't select it
			printArray(A); // print the set
			A[x] = 1; //// last digit, select it
			printArray(A);
			return;
		}
		A[x] = 0;   //either you will not select this digit
		combinations(A, x + 1);
		A[x] = 1;  //either you will select this digit
		combinations(A, x + 1);
	}


	//Main Array B= [A,B,C,D,E]
	//A=[0,0,1,1,0] ==> prints{C,D}
	//A=[0,0,0,0,0] ==> prints{Empty}
	public void printArray(int[] A) {
		bool isNULL = true;
		Console.Write("{");
		for (int i = 0; i < B.Count(); i++) {
			if (A[i] == 1) {
				Console.Write(B[i] + "");
				isNULL = false;
			}
		}
		if (isNULL == false) {
			Console.Write("}");
			Console.Write("  ");
		}	

		if (isNULL) {
			Console.Write("Empty");
			Console.Write("} ");
		}
	}



}
}