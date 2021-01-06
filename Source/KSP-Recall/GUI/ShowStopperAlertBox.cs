﻿/*
	This file is part of KSP-Recall
	(C) 2020-2021 Lisias T : http://lisias.net <support@lisias.net>

	KSP-Recall is double licensed, as follows:

	* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
	* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

	And you are allowed to choose the License that better suit your needs.

	KSP-Recall is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with KSP-Recall. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with KSP-Recall. If not, see <https://www.gnu.org/licenses/>.

*/
using UnityEngine;

namespace KSP_Recall.GUI
{
    internal static class ShowStopperAlertBox
    {
        private static readonly string MSG = @"Unfortunately KSP Recall got {0} Exceptions while checking the sanity of your instalment. It's not safe to continue, this will probably corrupt your savegames!

The KSP.log is listing every compromised part(s) on your installment, look for lines with '[KSP_Recall] ERROR: ' on the log line. Be aware that the parts being reported are not the culprits, but the Screaming Victims. There's no possible automated fix for these.";

        private static readonly string AMSG = @"call for help on the KSP Recall thread on the Forum (KSP will close). We will help you on diagnosing the Add'On that is troubling you. Publish your KSP.log on some file share service and mention it on the post";

        internal static void Show(int failure_count)
        {
            KSPe.Common.Dialogs.ShowStopperAlertBox.Show(
                string.Format(MSG, failure_count),
                AMSG,
                () => { Application.OpenURL("https://forum.kerbalspaceprogram.com/index.php?/topic/192048-*"); Application.Quit(); }
            );
            Log.detail("\"Houston, we have a Problem!\" was displayed");
        }
    }
}