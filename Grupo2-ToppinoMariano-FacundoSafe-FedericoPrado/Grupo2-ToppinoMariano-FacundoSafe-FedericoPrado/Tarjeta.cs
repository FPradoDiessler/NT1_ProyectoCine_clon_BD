using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo2_ToppinoMariano_FacundoSafe_FedericoPrado
{
    public abstract class Tarjeta : MedioDePago
    {
        private int numero;
        private DateTime fechaDeVencimiento;
        private int codigoSeguridad;
        private string nombre;


        public Tarjeta (int numero, DateTime fechaDeVencimiento, int codigoSeguridad, string nombre)
        {
            setNumero(numero);
            setFechaDeVencimiento(fechaDeVencimiento);
            setCodigoDeSeguridad(codigoSeguridad);
            setNombre(nombre);
        }

        /// <summary>
        /// revisa que el numero sea mayor a 13 digitos y menor a 20. Tambien que no hayan ingresado un numero negativo
        /// </summary>
        /// <param name="numero"></param>
        private void setNumero( int numero)
        {
            const int MINIMO = 13;
            const int MAXIMO= 20;

            int cantDigitos = numero.ToString().Length;
            
            if (numero < 0 || cantDigitos<MINIMO || cantDigitos>MAXIMO )
            {
                throw new ArgumentException("El numero debe ser mayor a 0, debe tener como minimo 13 y un maximo de 20");
            }

            this.numero = numero;
        }

       public Boolean mismoNumeroTarjeta(int numero)
        {
            return this.numero == numero;
        }

        /// <summary>
        /// Revisa que la fecha de la tarjeta sea mayor a la actual. el metodo compare devuelve distintos valores dependiendo 
        /// de que fecha sea mayor.
        /// </summary>
        /// <param name="fechaParametro"></param>
        private void setFechaDeVencimiento(DateTime fechaParametro)    

        {
            DateTime fechaHoy = DateTime.Now;

            if (fechaParametro == null)
            {
                throw new ArgumentException("La fecha de vencimiento no puede ser nula");
            }
            else if (DateTime.Compare(fechaParametro, fechaHoy) < 0)
            {
                throw new ArgumentException("La tarjeta esta vencida");
            }

            this.fechaDeVencimiento = fechaParametro;
        }

     

        /// <summary>
        /// revisa que tenga 3 digitos y el codigo sea mayor a 0 para que no envien un numero negativo
        /// </summary>
        /// <param name="codigo"></param>
        private void setCodigoDeSeguridad(int codigo)
        {
            const int CANTIDAD_DIGITOS_EXIGIDOS = 3;

            int cantDigitos = numero.ToString().Length;

            if( codigo<0 || cantDigitos!=3)
            {
                throw new ArgumentException("el codigo debe ser de 3 Digitos");
            }
            this.codigoSeguridad = codigo;
        }

        private void setNombre(string nombre)
        {

            if (nombre == "" || nombre == null)
            {
                throw new ArgumentException("El nombre no puede estar vacio");
            }

            this.nombre = nombre;
        }


    }
}
