using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportsOfEnterExitPiecesForLargeSampleList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesLargeSample>
    {
        public ReportsOfEnterExitPiecesForLargeSampleList()
        {
            this.spName = "ReportsOfEnterExitPieces";
            this.list = new List<RASF.General.Data.ReportsOfEnterExitPiecesLargeSample>();
            this.deletedlist = new List<RASF.General.Data.ReportsOfEnterExitPiecesLargeSample>();
        }

        public ReportsOfEnterExitPiecesForLargeSampleList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            List<System.Data.SqlClient.SqlParameter> Store_Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Store_Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode",RASF.General.Classes.Global.ContractsCode));
            RASF.General.Lists.ReportsOfEnterExitPiecesForStoreForLargeSampleList ReportsOfEnterExitPiecesForStoreList = new ReportsOfEnterExitPiecesForStoreForLargeSampleList();
            ReportsOfEnterExitPiecesForStoreList.Fill(Store_Parameters);

            List<System.Data.SqlClient.SqlParameter> Laboratory_Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Laboratory_Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode", RASF.General.Classes.Global.ContractsCode));
            RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryForLargeSampleList ReportsOfEnterExitPiecesForLaboratoryList = new ReportsOfEnterExitPiecesForLaboratoryForLargeSampleList();
            ReportsOfEnterExitPiecesForLaboratoryList.Fill(Laboratory_Parameters);

            base.Fill(parameters);

            foreach (RASF.General.Data.ReportsOfEnterExitPiecesLargeSample EnterExitPieces in this)
            {
                RASF.General.Lists.ReportsOfEnterExitPiecesForStoreForLargeSampleList EnterExitPiecesForStore = new RASF.General.Lists.ReportsOfEnterExitPiecesForStoreForLargeSampleList();
                EnterExitPiecesForStore.AddRange((from store in ReportsOfEnterExitPiecesForStoreList where store.PiecesCode == EnterExitPieces.Parts_Master_Code select store).ToList<RASF.General.Data.ReportsOfEnterExitPiecesForStoreLargeSample>());

                RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryForLargeSampleList EnterExitPiecesForLaboratory = new RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryForLargeSampleList();
                EnterExitPiecesForLaboratory.AddRange((from Lab in ReportsOfEnterExitPiecesForLaboratoryList where Lab.PiecesCode == EnterExitPieces.Parts_Master_Code select Lab).ToList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryLargeSample>());

                EnterExitPieces.ReportsOfEnterExitPiecesForStoreLargeSample = EnterExitPiecesForStore;
            }

            foreach (RASF.General.Data.ReportsOfEnterExitPiecesLargeSample EnterExitPieces in this)
            {
                RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryForLargeSampleList EnterExitPiecesForLaboratory = new RASF.General.Lists.ReportsOfEnterExitPiecesForLaboratoryForLargeSampleList();
                EnterExitPiecesForLaboratory.AddRange((from Lab in ReportsOfEnterExitPiecesForLaboratoryList where Lab.PiecesCode == EnterExitPieces.Parts_Master_Code select Lab).ToList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryLargeSample>());

                EnterExitPieces.ReportsOfEnterExitPiecesForLaboratoryLargeSample = EnterExitPiecesForLaboratory;
            }

            return this.list.Count();
        }
    
    }
}

