using Dadata;
using Dadata.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest2Programm
{
    public class DaDataService
    {
        private const string _token = "b9ced665aed90643d23180e52c80b99001bb13c6";
        private const string _secret = "03b11b4a997baaedc9d5d1c80f121b0e4c401212";

        public async Task<Address> AddressStandardizite(string adress)
        {
            var api = new CleanClientAsync(_token, _secret);
            var result = await api.Clean<Address>(adress);
            return result;
        }
    }
}
