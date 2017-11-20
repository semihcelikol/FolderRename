using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderRename
{
    class MessageHelper
    {
        #region Mesaj ile ilgili classlar.

        /// <summary>
        /// Ekrana bilgi mesajı çıkartır.
        /// </summary>
        /// <param name="_message"></param>
        /// <param name="_caption"></param>
        public void messageInformationShow(string _message, string _caption)
        {
            MessageBox.Show(_message, _caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Ekrana hata mesajı çıkartır.
        /// </summary>
        /// <param name="_message"></param>
        /// <param name="_caption"></param>
        public void messageErrorShow(string _message, string _caption)
        {
            MessageBox.Show(_message, _caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Ekrana uyarı mesajı çıkartır.
        /// </summary>
        /// <param name="_message"></param>
        /// <param name="_caption"></param>
        public void messageWarningShow(string _message, string _caption)
        {
            MessageBox.Show(_message, _caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
    }
}
