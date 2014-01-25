using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTunes
{
    class Musique
    {
        #region Constructeurs
        public Musique() { }
        public Musique(int id, string nm,string art, string alb,float tps,int classmt,int lect,DateTime dernlect )
        {
            ID = id;
            Nom = nm;
            Artiste = art;
            Album = alb;
            Duree = tps;
            Classement = classmt;
            Lectures = lect;
            DerniereLecture = dernlect;

        }
        #endregion

        #region Propritetes
        protected int ID { get; set; }
        protected string Nom { get; set; }
        protected string Artiste { get; set; }
        protected string Album { get; set; }
        protected float Duree { get; set; }
        protected int Classement { get; set; }
        protected int Lectures { get; set; }
        protected DateTime DerniereLecture { get; set; }
        #endregion
    }
}
