using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitVertcoin(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Vertcoin.Instance, networkType)
			{
				MinRPCVersion = 140000
			});
		}

		public NBXplorerNetwork GetVTC()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Vertcoin.Instance.CryptoCode);
		}
	}
}
