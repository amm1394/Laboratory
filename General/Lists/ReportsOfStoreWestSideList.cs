using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportsOfStoreWestSideList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesWestSide>
    {
        public ReportsOfStoreWestSideList()
        {
            this.spName = "ReportsOfEnterExitPieces";
            this.list = new List<RASF.General.Data.ReportsOfEnterExitPiecesWestSide>();
            this.deletedlist = new List<RASF.General.Data.ReportsOfEnterExitPiecesWestSide>();
        }

        public ReportsOfStoreWestSideList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            List<System.Data.SqlClient.SqlParameter> Store_Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Store_Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode",RASF.General.Classes.Global.ContractsCode));
            RASF.General.Lists.ReportsOfEnterExitPiecesForStoreWestSideList ReportsOfEnterExitPiecesForStoreList = new ReportsOfEnterExitPiecesForStoreWestSideList();
            ReportsOfEnterExitPiecesForStoreList.Fill(Store_Parameters);

            List<System.Data.SqlClient.SqlParameter> Laboratory_Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Laboratory_Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode", RASF.General.Classes.Global.ContractsCode));
            RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryWestSideList ReportsOfEnterExitPiecesForLaboratoryList = new ReportsOfEnterExitPiecesForLaboratoryWestSideList();
            ReportsOfEnterExitPiecesForLaboratoryList.Fill(Laboratory_Parameters);

            base.Fill(parameters);

            foreach (RASF.General.Data.ReportsOfEnterExitPiecesWestSide EnterExitPieces in this)
            {
                RASF.General.Lists.ReportsOfEnterExitPiecesForStoreWestSideList EnterExitPiecesForStore = new RASF.General.Lists.ReportsOfEnterExitPiecesForStoreWestSideList();
                EnterExitPiecesForStore.AddRange((from store in ReportsOfEnterExitPiecesForStoreList where store.PiecesCode == EnterExitPieces.Parts_Master_Code select store).ToList<RASF.General.Data.ReportsOfEnterExitPiecesForStoreWestSide>());

                //RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryWestSideList EnterExitPiecesForLaboratory = new RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryWestSideList();
                //EnterExitPiecesForLaboratory.AddRange((from Lab in ReportsOfEnterExitPiecesForLaboratoryList where Lab.PiecesCode == EnterExitPieces.Parts_Master_Code select Lab).ToList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryWestSide>());

                EnterExitPieces.ReportsOfEnterExitPiecesForStoreWestSide = EnterExitPiecesForStore;
            }

            foreach (RASF.General.Data.ReportsOfEnterExitPiecesWestSide EnterExitPieces in this)
            {
                RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryWestSideList EnterExitPiecesForLaboratory = new RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryWestSideList();
                EnterExitPiecesForLaboratory.AddRange((from Lab in ReportsOfEnterExitPiecesForLaboratoryList where Lab.PiecesCode == EnterExitPieces.Parts_Master_Code select Lab).ToList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryWestSide>());

                EnterExitPieces.ReportsOfEnterExitPiecesForLaboratoryWestSide = EnterExitPiecesForLaboratory;
            }

            return this.list.Count();
        }
    
    }
}

