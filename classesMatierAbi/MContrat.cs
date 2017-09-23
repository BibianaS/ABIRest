/***********************************************************************
 * Module:  Contrat.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Contrat
 ***********************************************************************/

using System;
namespace ABI
{
    public abstract class MContrat
    {
        private Int32 numeroContrat;
        private String qualification;
        private String statut;
        private Decimal salaireBrut = 0;
        private DateTime dateDebut;
        private DateTime? dateFinReel = null;
        
        /// <summary>
        /// Constructeur pour le CDI, CDD, Stage
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateDebut"></param>
        public MContrat(Int32 numContrat, String qualification, Decimal salaireBrut, DateTime dateDebut)
        {
            this.NumeroContrat = numContrat;
            this.Qualification = qualification;
            this.SalaireBrut = salaireBrut;
            this.DateDebut = dateDebut;
            this.Statut = "Actif";
        }

        /// <summary>
        /// Constructeur pour l'Interim
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateDebut"></param>
        public MContrat(Int32 numContrat, String qualification, DateTime dateDebut)
        {
            this.NumeroContrat = numContrat;
            this.Qualification = qualification;
            this.Statut = "Actif";
        }
        
        /// <summary>
        /// Propriete du numero de contrat
        /// </summary>
        public Int32 NumeroContrat
        {
            get
            {
                return this.numeroContrat;
            }

            set
            {
                this.numeroContrat = value;
            }
        }

        /// <summary>
        /// Propriete de la qualification
        /// </summary>
        public String Qualification
        {
            get
            {
                return qualification;
            }
            set
            {
                this.qualification = value;
            }
        }

        /// <summary>
        /// Propriete du Statut
        /// </summary>
        public String Statut
        {
            get
            {
                return statut;
            }
            set
            {
                statut = value;
            }
        }
        
        /// <summary>
        /// Propriete de la date de debut du contrat
        /// </summary>
        public DateTime DateDebut
        {
            get
            {
                return this.dateDebut;
            }

            set
            {

                Int32 result = DateTime.Compare(value, DateTime.Today);
                if (result < 0)
                {
                    throw new Exception("Merci de reinseigner une date future");
                }
                if (result >= 0)
                {
                    this.dateDebut = value;
                }
            }
        }

        /// <summary>
        /// Propriete du salaire brut
        /// </summary>
        public Decimal SalaireBrut
        {
            get
            {
                return salaireBrut;
            }

            set
            {
                salaireBrut = value;
            }
        }

        /// <summary>
        /// Methode qui decrit le contrat
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Date creation du contrat : " + DateTime.Now + ". Num�ro de contrat : " + NumeroContrat + ". Qualification : " + Qualification + ". Statut : " + Statut + ". Date debut contrat : " + DateDebut ;
        }
    }
}