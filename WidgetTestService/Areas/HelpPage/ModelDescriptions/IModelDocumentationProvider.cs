#pragma warning disable 1591
using System;
using System.Reflection;

namespace WidgetTestService.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}