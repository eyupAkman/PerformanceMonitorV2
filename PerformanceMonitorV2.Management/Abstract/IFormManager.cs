using System.Windows.Forms;

namespace PerformanceMonitorV2.Management.Abstract
{
    public interface IFormManager
    {
        /// <summary>
        /// Brings a new form with fade effect
        /// </summary>
        /// <param name="form"> Any form </param>
        void GetNewForm(Form form);

        /// <summary>
        /// Form switch with fade effect
        /// </summary>
        /// <param name="currentForm"> Current form </param>
        /// <param name="nextForm"> Next form </param>
        void SwitchForm(Form currentForm, Form nextForm);

        /// <summary>
        /// Intro animation
        /// </summary>
        /// <param name="introForm"> Intro form (logo) </param>
        /// <param name="nextForm"> Next form </param>
        void Intro(Form introForm, Form nextForm);

        /// <summary>
        /// Exit from application
        /// </summary>
        /// <param name="form"> Current form </param>
        void Exit(Form form);
    }
}