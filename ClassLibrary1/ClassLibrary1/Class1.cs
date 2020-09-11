using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Array;
//using System.Quantum.Operations;




namespace ClassLibrary1
{
    
    public class quantum
    {
        Complex[] qubitVector;

     /*Комплекснае числа
     *@param no0 - комплексное число, которое передаем 
     *@param no1 - комплексное число
     */
        public void Qubit(Complex no0, Complex no1) {
		qubitVector = new Complex[2];
		qubitVector[0] = no0;
		qubitVector[1] = no1;
	}
        /*
         * @param qubitVector - массив из двух комплексных чисел
         * копирование массива
         */
        public void Qubit(Complex[] qubitVector) {
      //   this.qubitVector =Array.copyOf(qubitVector, qubitVector.length);
         Array.Copy(qubitVector, this.qubitVector, qubitVector.Length);
	}

        public Complex[] getQubit() //getQubit - name
        {
            Complex[] copyOfQubitVector = qubitVector;//объявление массива
            return copyOfQubitVector;
        }

        public bool isValid(){
           double sum=0.0;
          foreach(Complex c in this.qubitVector) {
               double mod=ComplexMath.mod(c);
              sum+=mod*mod;
            }
    return (sum==1.0);
}

    }
}
