using System;
using System.Reflection;

namespace ApiRestfull_ObtieneValoresGenericos.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}