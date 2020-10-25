using System;
using System.Threading;

namespace fabricantevendedor
{
    public class Fabricante
    {
        private Almacen _a;
        private Thread _t;
        private Random _rnd = new Random();

       

        
        public Fabricante(Almacen a)
        {
            
            this._a = a;
            
        }

        public void Fabrica(int initTime , int cantidad)
        {
            this._t = new Thread(() => this._Accion(initTime, cantidad));
            this._t.Start();
        }

        public void Termina()
        {
            _t.Join();
        }

        private void _Accion(int initTime, int cantidad)
        {
            
            
            for (int i = 0; i < cantidad; i++)
            {
                
                Thread.Sleep(initTime);
                _a.Guardar();
            }
        }
    }

}