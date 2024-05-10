using SuperClient.models;
using SuperClient.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.presenters
{
    internal class ProfilePresenter: IProfilePresenter
    {
        IProfileView view;
        ProfileModel model;

        public ProfilePresenter(IProfileView view)
        {
            this.view = view;
            this.model = new ProfileModel();
        }

        public async Task Profile()
        {
            throw new NotImplementedException();
        }
    }
}
