using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportsOfEnterExitPiecesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPieces>
    {
        public ReportsOfEnterExitPiecesList()
        {
            this.spName = "ReportsOfEnterExitPieces";
            this.list = new List<RASF.General.Data.ReportsOfEnterExitPieces>();
            this.deletedlist = new List<RASF.General.Data.ReportsOfEnterExitPieces>();
        }

        public ReportsOfEnterExitPiecesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            List<System.Data.SqlClient.SqlParameter> Store_Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Store_Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode",RASF.General.Classes.Global.ContractsCode));
            RASF.General.Lists.ReportsOfEnterExitPiecesForStoreList ReportsOfEnterExitPiecesForStoreList = new ReportsOfEnterExitPiecesForStoreList();
            ReportsOfEnterExitPiecesForStoreList.Fill(Store_Parameters);

            List<System.Data.SqlClient.SqlParameter> Laboratory_Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Laboratory_Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode", RASF.General.Classes.Global.ContractsCode));
            RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryList ReportsOfEnterExitPiecesForLaboratoryList = new ReportsOfEnterExitPiecesForLaboratoryList();
            ReportsOfEnterExitPiecesForLaboratoryList.Fill(Laboratory_Parameters);

            base.Fill(parameters);

            foreach (RASF.General.Data.ReportsOfEnterExitPieces EnterExitPieces in this)
            {
                RASF.General.Lists.ReportsOfEnterExitPiecesForStoreList EnterExitPiecesForStore = new RASF.General.Lists.ReportsOfEnterExitPiecesForStoreList();
                EnterExitPiecesForStore.AddRange((from store in ReportsOfEnterExitPiecesForStoreList where store.PiecesCode == EnterExitPieces.Parts_Master_Code select store).ToList<RASF.General.Data.ReportsOfEnterExitPiecesForStore>());

                RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryList EnterExitPiecesForLaboratory = new RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryList();
                EnterExitPiecesForLaboratory.AddRange((from Lab in ReportsOfEnterExitPiecesForLaboratoryList where Lab.PiecesCode == EnterExitPieces.Parts_Master_Code select Lab).ToList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratory>());

                EnterExitPieces.ReportsOfEnterExitPiecesForStore = EnterExitPiecesForStore;
            }

            foreach (RASF.General.Data.ReportsOfEnterExitPieces EnterExitPieces in this)
            {
                RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryList EnterExitPiecesForLaboratory = new RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryList();
                EnterExitPiecesForLaboratory.AddRange((from Lab in ReportsOfEnterExitPiecesForLaboratoryList where Lab.PiecesCode == EnterExitPieces.Parts_Master_Code select Lab).ToList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratory>());

                EnterExitPieces.ReportsOfEnterExitPiecesForLaboratory = EnterExitPiecesForLaboratory;
            }

            return this.list.Count();
        }
    
    }
}

