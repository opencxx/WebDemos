﻿using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SereneDefault.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneDefault.Administration.LanguageRow;


namespace SereneDefault.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}