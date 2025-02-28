//
// Copyright Fela Ameghino 2015-2024
//
// Distributed under the GNU General Public License v3.0. (See accompanying
// file LICENSE or copy at https://www.gnu.org/licenses/gpl-3.0.txt)
//
using Telegram.Services;
using Telegram.Td.Api;

namespace Telegram.ViewModels.Settings.Privacy
{
    public partial class SettingsPrivacyAllowP2PCallsViewModel : SettingsPrivacyViewModelBase
    {
        public SettingsPrivacyAllowP2PCallsViewModel(IClientService clientService, ISettingsService settingsService, IEventAggregator aggregator)
            : base(clientService, settingsService, aggregator, new UserPrivacySettingAllowPeerToPeerCalls())
        {
        }
    }
}
