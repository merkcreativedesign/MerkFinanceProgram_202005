﻿using System;
using System.Collections.Generic;
using System.Linq;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MerkDataBaseBusinessLogicProject.MerkDataBaseBusinessLogic.MerkModelCreateor.DBCommon;

namespace MerkDataBaseBusinessLogicProject
{
	public partial class VisitTiming_VitalSign : DBCommon, IDBCommon, IPEMR_Element
	{
		MerkFinanceEntities _context;
		private static List<VisitTiming_VitalSign> _items;
		public static List<VisitTiming_VitalSign> ItemsList = new List<VisitTiming_VitalSign>();

		#region ColumnNames

		public static String VisitTimingID_ColumnaName
		{
			get { return "VisitTimingID"; }
		}

		public static String Treatment_ColumnaName
		{
			get { return "Treatment"; }
		}

		public static String StepOrderIndex_ColumnaName
		{
			get { return "StepOrderIndex"; }
		}

		#endregion

		public override bool LoadFromDB
		{
			get { return false; }
		}

		public override DBCommonEntitiesType TableType
		{
			get { return DBCommonEntitiesType.TransactionsEntities; }
		}

		public override bool LoadItemsList()
		{
			ItemsList.Clear();

			ItemsList = DBContext_External.VisitTiming_VitalSign.ToList();
			return true;
		}

		public int TableIdentityID
		{
			get { return (int)DB_TableIdentity.VisitTiming_VitalSign; }
		}

		public List<string> ChildrenItemsList
		{
			get
			{
				List<string> list = new List<string>();
				return list;
			}
		}

		public string EntityName
		{
			get { return "VisitTiming_VitalSign"; }
		}

		public IDBCommon GetSpecificEntity(MerkFinanceEntities context, int id)
		{
			return context.VisitTiming_VitalSign.FirstOrDefault(item => item.ID.Equals(id));
		}

		#region Implementation of IPEMR_Element

		public DB_PEMR_ElementType PEMR_Element
		{
			get { return DB_PEMR_ElementType.VisitTiming_VitalSign; }
		}

		public int OrderIndex
		{
			get
			{
				PEMR_Elemet_p element = null;
				if (PEM_ElementPrintOrder_cu.ItemsList.Count == 0)
				{
					element = PEMR_Elemet_p.ItemsList.Find(
						item => Convert.ToInt32(item.ID).Equals((int)DB_PEMR_ElementType.VisitTiming_VitalSign));
					//PEMR_Elemet_p parentElement = 
					if (element != null)
						return Convert.ToInt32(element.DefaultOrderIndex);
					return 0;
				}

				PEM_ElementPrintOrder_cu elementPrintOrder = PEM_ElementPrintOrder_cu.ItemsList.Find(
					item => Convert.ToInt32(item.PEMR_Elemet_P_ID)
						.Equals((int)DB_PEMR_ElementType.VisitTiming_VitalSign));
				if (elementPrintOrder != null)
					return elementPrintOrder.OrderIndex;

				element = PEMR_Elemet_p.ItemsList.Find(
					item => Convert.ToInt32(item.ID).Equals((int)DB_PEMR_ElementType.VisitTiming_VitalSign));
				if (element != null)
					return Convert.ToInt32(element.DefaultOrderIndex);
				return 0;
			}
		}

		public string ElementName
		{
			get
			{
				PEMR_Elemet_p element = PEMR_Elemet_p.ItemsList.Find(
					item => Convert.ToInt32(item.ID).Equals((int)DB_PEMR_ElementType.VisitTiming_VitalSign));
				if (element == null)
					return String.Empty;

				return element.Name_S;
			}
		}

		public string TranslatedItem { get; set; }

		public string TranslatedItemValue { get; set; }
		public PEMRElementStatus PEMRElementStatus { get; set; }

		#endregion

		public WeightUnit_p WeightUnit
		{
			get
			{
				if (WeightUnit_P_ID == null)
					return null;
				WeightUnit_p weight = WeightUnit_p.ItemsList.Find(item =>
					Convert.ToInt32(item.ID).Equals(Convert.ToInt32(WeightUnit_P_ID)));
				return weight;
			}
		}

		public string WeightUnitName
		{
			get
			{
				if (WeightUnit == null)
					return string.Empty;
				return WeightUnit.Name_P;
			}
		}

		public TemperatureUnit_p TemperatureUnit
		{
			get
			{
				if (TemperatureUnit_P_ID == null)
					return null;
				TemperatureUnit_p temp = TemperatureUnit_p.ItemsList.Find(item =>
					Convert.ToInt32(item.ID).Equals(Convert.ToInt32(TemperatureUnit_P_ID)));
				return temp;
			}
		}

		public string TemperatureUnitName
		{
			get
			{
				if (TemperatureUnit == null)
					return string.Empty;
				return TemperatureUnit.Name_P;
			}
		}

		public HeightUnit_p HeightUnitUnit
		{
			get
			{
				if (HeightUnit_P_ID == null)
					return null;
				HeightUnit_p height = HeightUnit_p.ItemsList.Find(item =>
					Convert.ToInt32(item.ID).Equals(Convert.ToInt32(HeightUnit_P_ID)));
				return height;
			}
		}

		public string HeightUnitUnitName
		{
			get
			{
				if (HeightUnitUnit == null)
					return string.Empty;
				return HeightUnitUnit.Name_P;
			}
		}

		public bool IsWeightRegistered
		{
			get { return WeightUnit_P_ID != null && WeightAmount != null; }
		}

		public bool IsHeightRegistered
		{
			get { return HeightUnit_P_ID != null && HeightAmount != null; }
		}

		public bool IsTemperatureRegistered
		{
			get { return TemperatureUnit_P_ID != null && TemperatureAmount != null; }
		}

		public bool IsBloodPressureRegistered
		{
			get { return BloodPressureAmountHigh != null && BloodPressureAmountLow != null; }
		}
	}
}
