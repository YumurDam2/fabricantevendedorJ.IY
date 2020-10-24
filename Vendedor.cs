using System;
using System.Threading;

namespace fabricantevendedor
{
    public class Vendedor
    {
        private Almacen _a;
        private Thread _t;
        private Thread _t2;
        private Thread _t3;
        private Random _rnd = new Random();
        public Vendedor(Almacen a)
        {
            this._a = a;
        }

        public void Vende()
        {
            this._t = new Thread(() => this._Accion());
            this._t.Start();

            this._t2 = new Thread(() => this._Accion2());
            this._t2.Start();

            this._t3 = new Thread(() => this._Accion3());
            this._t3.Start();
        }

        public void Termina()
        {
            _t.Join();
            _t2.Join();
            _t3.Join();
        }

        private void _Accion()
        {
            int ms;
            for (int i = 0; i < 3; i++)
            {
                ms = _rnd.Next(800);
                Thread.Sleep(ms);
                _a.Sacar();
            }
            
        }
        private void _Accion2()
        {
            int ms;
            for (int i = 0; i < 3; i++)
            {
                ms = _rnd.Next(1000);
                Thread.Sleep(ms);
                _a.Sacar();
            }
            
        }
        private void _Accion3()
        {
            int ms;
            for (int i = 0; i < 2; i++)
            {
                ms = _rnd.Next(1200);
                Thread.Sleep(ms);
                _a.Sacar();
            }
            
        }
    }
}