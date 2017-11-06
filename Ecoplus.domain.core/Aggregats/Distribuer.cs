﻿using System;

namespace Ecoplus.domain.core.Aggregats
{
    public class Distribuer
    {
        public Distribuer(int id, DateTime datedistribuee, float qteDistribuee, int idExploitant, int idDepot)
        {
            Id = id;
            Datedistribuee = datedistribuee;
            QteDistribuee = qteDistribuee;
            IdExploitant = idExploitant;
            IdDepot = idDepot;
        }

        public int Id { get; private set; }
        public DateTime Datedistribuee { get; private set; }
        public float QteDistribuee { get; private set; }
        public int IdExploitant { get; private set; }
        public int IdDepot { get; private set; }

        public Distribuer Ajout(int id, DateTime datedistribuee, float qteDistribuee, int idExploitant, int idDepot)
        {
            return new Distribuer(id, datedistribuee, qteDistribuee, idExploitant, idDepot);
        }

        public void Modifier(int id, Distribuer distribution)
        {
            if (id != distribution.Id) return;
            Datedistribuee = distribution.Datedistribuee;
            QteDistribuee = distribution.QteDistribuee;
            IdExploitant = distribution.IdExploitant;
            IdDepot = distribution.IdDepot;
        }
    }
}