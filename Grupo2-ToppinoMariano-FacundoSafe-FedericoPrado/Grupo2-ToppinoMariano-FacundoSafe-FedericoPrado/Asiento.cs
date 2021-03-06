using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo2_ToppinoMariano_FacundoSafe_FedericoPrado
{
    class Asiento
    {

        private char fila;
        private int numero;
        public Asiento(char fila, int nro)
        {
            SetFila(fila);
            SetNro(nro);
        }

        public char GetFila()
        {
            return this.fila;
        }

        public int GetNumero()
        {
            return this.numero;
        }

        private void SetFila(char fila)
        {
            this.fila = ValidarFila(fila);
        }

        private char ValidarFila(char fila)
        {
            char[] filasPosibles = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            bool isValid = false;

            foreach(char x in filasPosibles)
            {
                if(fila == x)
                {
                    isValid = true;
                }
            }

            if (!isValid)
            {
                throw new ArgumentException("Ingrese una fila válida (a - j)");
            }

            return fila;
        }
    
        private void SetNro(int nro)
        {
            this.numero = ValidarNro(nro);
        }

        private int ValidarNro(int nro)
        {
            if(nro <= 0 || nro > 15)
            {
                throw new ArgumentException("Ingrese un número válido (1-15)");
            }

            return nro;
        }

        public bool MismoAsiento(char fila, int numero)
        {
            return this.fila == fila && this.numero == numero;
        }
    }
}
