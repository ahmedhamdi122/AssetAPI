﻿using Asset.Domain;
using Asset.Domain.Services;
using Asset.Models;
using Asset.ViewModels.MasterAssetAttachmentVM;
using Asset.ViewModels.MasterAssetVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Core.Services
{
    public class MasterAssetService : IMasterAssetService
    {
        private IUnitOfWork _unitOfWork;

        public MasterAssetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        #region Main Functions

        public IndexMasterAssetVM GetAll(SortAndFilterMasterAssetVM data, int pageNumber, int pageSize)
        {
            return _unitOfWork.MasterAssetRepository.GetAll(data, pageNumber, pageSize);
        }

        public IEnumerable<MasterAsset> GetAllMasterAssets()
        {
            return _unitOfWork.MasterAssetRepository.GetAllMasterAssets();
        }


        public int Add(CreateMasterAssetVM masterAssetObj)
        {
            return _unitOfWork.MasterAssetRepository.Add(masterAssetObj);
        }

        public EditMasterAssetVM GetById(int id)
        {
            return _unitOfWork.MasterAssetRepository.GetById(id);
        }

        public int Delete(int id)
        {
            var masterAssetObj = _unitOfWork.MasterAssetRepository.GetById(id);
            _unitOfWork.MasterAssetRepository.Delete(masterAssetObj.Id);
            _unitOfWork.CommitAsync();
            return masterAssetObj.Id;
        }

        public int CountMasterAssets()
        {
            return _unitOfWork.MasterAssetRepository.CountMasterAssets();
        }


        public int Update(EditMasterAssetVM masterAssetObj)
        {
            _unitOfWork.MasterAssetRepository.Update(masterAssetObj);
            _unitOfWork.CommitAsync();
            return masterAssetObj.Id;
        }
        public GeneratedMasterAssetCodeVM GenerateMasterAssetcode()
        {
            return _unitOfWork.MasterAssetRepository.GenerateMasterAssetcode();
        }
        #endregion


        #region Search Auto Complete 
        public IEnumerable<MasterAsset> AutoCompleteMasterAssetName(string name)
        {
            return _unitOfWork.MasterAssetRepository.AutoCompleteMasterAssetName(name);
        }

        public IEnumerable<IndexMasterAssetVM.GetData> AutoCompleteMasterAssetName2(string name)
        {
            return _unitOfWork.MasterAssetRepository.AutoCompleteMasterAssetName2(name);
        }

        public IEnumerable<IndexMasterAssetVM.GetData> AutoCompleteMasterAssetName3(string name, int hospitalId)
        {
            return _unitOfWork.MasterAssetRepository.AutoCompleteMasterAssetName3(name, hospitalId);
        }

        #endregion


        #region Master Asset Attachments

        public int CreateMasterAssetDocuments(CreateMasterAssetAttachmentVM attachObj)
        {
            return _unitOfWork.MasterAssetRepository.CreateMasterAssetDocuments(attachObj);
        }

        public int DeleteMasterAssetAttachment(int id)
        {
            return _unitOfWork.MasterAssetRepository.DeleteMasterAssetAttachment(id);
        }

        public IEnumerable<MasterAsset> DistinctAutoCompleteMasterAssetName(string name)
        {
            return _unitOfWork.MasterAssetRepository.DistinctAutoCompleteMasterAssetName(name);
        }

        public MasterAssetAttachment GetLastDocumentForMsterAssetId(int masterId)
        {
            return _unitOfWork.MasterAssetRepository.GetLastDocumentForMsterAssetId(masterId);
        }

        #endregion


        public List<CountMasterAssetBrands> CountMasterAssetsByBrand(int hospitalId)
        {
            return _unitOfWork.MasterAssetRepository.CountMasterAssetsByBrand(hospitalId);
        }

        public List<CountMasterAssetSuppliers> CountMasterAssetsBySupplier(int hospitalId)
        {
            return _unitOfWork.MasterAssetRepository.CountMasterAssetsBySupplier(hospitalId);
        }

        public IEnumerable<MasterAsset> GetAllMasterAssetsByHospitalId(int hospitalId, string userId)
        {
            return _unitOfWork.MasterAssetRepository.GetAllMasterAssetsByHospitalId(hospitalId, userId);
        }

        public IEnumerable<MasterAsset> GetAllMasterAssetsByHospitalId(int hospitalId)
        {
            return _unitOfWork.MasterAssetRepository.GetAllMasterAssetsByHospitalId(hospitalId);
        }

        public IEnumerable<MasterAssetAttachment> GetAttachmentByMasterAssetId(int assetId)
        {
            return _unitOfWork.MasterAssetRepository.GetAttachmentByMasterAssetId(assetId);
        }


       public IEnumerable<IndexMasterAssetVM.GetData> GetListMasterAsset()
        {
            return _unitOfWork.MasterAssetRepository.GetListMasterAsset();
        }

        public IEnumerable<IndexMasterAssetVM.GetData> GetTop10MasterAsset(int hospitalId)
        {
            return _unitOfWork.MasterAssetRepository.GetTop10MasterAsset(hospitalId);
        }


        public int UpdateMasterAssetImageAfterInsert(CreateMasterAssetVM masterAssetObj)
        {
            return _unitOfWork.MasterAssetRepository.UpdateMasterAssetImageAfterInsert(masterAssetObj);
        }

        public ViewMasterAssetVM ViewMasterAsset(int id)
        {
            return _unitOfWork.MasterAssetRepository.ViewMasterAsset(id);
        }

        //public IEnumerable<string> GetDistintMasterAssetModels(string name)
        //{
        //    return _unitOfWork.MasterAssetRepository.GetDistintMasterAssetModels(name);
        //}

        public IEnumerable<string> GetDistintMasterAssetModels(int brandId,string name)
        {
            return _unitOfWork.MasterAssetRepository.GetDistintMasterAssetModels(brandId,name);
        }
        public IEnumerable<Brand> GetDistintMasterAssetBrands(string name)
        {
            return _unitOfWork.MasterAssetRepository.GetDistintMasterAssetBrands(name);
        }
    }
}
