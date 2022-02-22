using Microsoft.AspNetCore.Components;
using System;

namespace Radzen.Blazor
{
    /// <summary>
    /// A validator component which checks if a component has value.
    /// Must be placed inside a <see cref="RadzenTemplateForm{TItem}" />
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;RadzenTemplateForm TItem="Model" Data=@model&gt;
    ///   &lt;RadzenTextBox style="display: block" Name="Email" @bind-Value=@model.Email /&gt;
    ///   &lt;RadzenRequiredValidator Component="Email" Text="Email is required" Style="position: absolute" /&gt;
    /// &lt;/RadzenTemplateForm&gt;
    /// @code {
    ///  class Model
    ///  {
    ///    public string Email { get; set; }
    ///  }
    ///  
    ///  Model model = new Model();
    /// }
    /// </code>
    /// </example>
    public class RadzenCustomValidator : ValidatorBase
    {
        /// <summary>
        /// Gets or sets the message displayed when the component is invalid. Set to <c>"Custom"</c> by default.
        /// </summary>
        [Parameter]
        public override string Text { get; set; } = "Custom";

        /// <summary>
        /// The validate function
        /// </summary>
        [Parameter]
        public Func<IRadzenFormComponent, bool> ValidateFunc { get; set; }

        /// <inheritdoc />
        protected override bool Validate(IRadzenFormComponent component)
        {
            if (ValidateFunc != null)
                return ValidateFunc(component);
            return true;
        }

        /// <summary>
        /// Specifies a default value. If the component value is equal to <c>DefaultValue</c> it is considered invalid.
        /// </summary>
        [Parameter]
        public object DefaultValue { get; set; }
    }
}