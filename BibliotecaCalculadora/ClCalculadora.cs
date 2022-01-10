using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    public class ClCalculadora
    {
        public int Sumar(int v1, int v2)
        {
            return (v1 + v2);
        }

        public long Multiplicar(long v1, long v2)
        {
            long result = 0;
            for (int i=0; i < v2;i++)
            {
                result += v1;
            }
            return result;
        }
        public int ProducteVectorial(int[] array1, int[] array2)
        {
            int resultat=0;
            for (int i=0; i<array1.Length;i++)
            {
                resultat =  resultat + array1[i] * array2[i];

            }
            return resultat;

        }

        public int[] invertirVector(int[] array1)
        {
            /*int[] vResultat = new int[array1.Length];

            for (int i= array1.Length-1, j=0; i>= 0;i--, j++)
            {
                    vResultat[j] = array1[i];
            }
            return vResultat;*/

            Array.Reverse(array1);

            return array1;
        }

        public char[] OrdenarVector(char[] array1)
        {
            Array.Sort(array1);

            return array1;
        }

        public int buscarMaximo(int[] array1)
        {
            return array1.Max();
        }

        public int buscarMaximo2(int[] array1)
        {
            return array1.Max();
        }
        public int buscarMinimo(int[] array1)
        {
            return array1.Min();
        }
        
       public int QuantesVegades(string cadena, char lletra)
        {
            int lletraTrobada = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                /*if (cadena[i] != 0)
                {
                    while (cadena[i] != '\0')
                    {*/
                        if (cadena[i] == lletra)
                        {
                            lletraTrobada++;
                        }
                    //}
                //}
            }
            return lletraTrobada;
        }
        
        public int[] OnEs(string cadena, char lletra)
        {
            int [] indexPos = { };
            int j = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                        if (cadena[i] == lletra)
                        {
                            indexPos[j] = i;
                            j++;
                        }
            }
            return indexPos;
        }
        
        public int QuantesVocals(string cadena)
        {
            int numVocals = 0;
            char[] vocals = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < cadena.Length; i++)
            {
               /*if (cadena[i] != null)
                {
                    while (cadena[i] != '\0')
                    {*/
                        for (int j = 0; j < vocals.Length; j++)
                        {
                            if (cadena[i] == vocals[j])
                            {
                                numVocals++;
                            }
                        }
                    //}
                //}
            }
            return numVocals;
        }

        public int QuantesConsonants(string cadena)
        {
            int numConsonants = 0;
            char[] vocals = {'a','e','i','o','u'};

            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = 0; j < vocals.Length; j++)
                {
                    if (cadena[i] != vocals[j])
                    {
                        numConsonants++;
                    }
                }
            }
            return numConsonants;
        }
    }
}
