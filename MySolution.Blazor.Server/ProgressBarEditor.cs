using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using Microsoft.AspNetCore.Components;
using MySolution.Blazor.Server.Editors;

namespace MySolution.Blazor.Server
{
    [PropertyEditor(typeof(int), false)]
    public class ProgressBarEditor : BlazorPropertyEditorBase
    {
        public ProgressBarEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        protected override IComponentAdapter CreateComponentAdapter() => new InputAdapter(new InputModel());
        protected override RenderFragment CreateViewComponentCore(object dataContext)
        {
            var taskObject = (MySolution.Module.BusinessObjects.DemoTask)dataContext;
            InputModel componentModel = new InputModel() { Value = taskObject.Progress };
            return ProgressBarRenderer.Create(componentModel);
        }
    }
}
