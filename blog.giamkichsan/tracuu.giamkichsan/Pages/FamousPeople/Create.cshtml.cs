using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tracuu.giamkichsan.Entities;
using tracuu.giamkichsan.Model;
using tracuu.giamkichsan.Services;

namespace tracuu.giamkichsan.Pages.FamousPeople
{
    public class CreateModel : PageModel
    {
		public PersonCommunityModel personCommunityModel { get; set; }
		public List<WorkCategoryEntity> workCategoriesEntity { get; set; }
		private PersonCommunityServices personCommunityServices = new PersonCommunityServices();
        private WorkCategoryServices workCategoryServices = new WorkCategoryServices();
        public void OnGet(int ID = 0)
        {
            workCategoriesEntity = workCategoryServices.GetAll();
            if (ID == 0)
                personCommunityModel = new PersonCommunityModel();
            else
                personCommunityModel = personCommunityServices.GetByID(ID);
        }
        public void OnPost(PersonCommunityModel personCommunityModel)
		{
            if(personCommunityModel.ID != 0)
			{
                personCommunityServices.Edit(personCommunityModel);
            }
            else
			{
                personCommunityServices.Insert(personCommunityModel);
            }
		}
    }
}
