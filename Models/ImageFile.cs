﻿using EPiServer.Framework.DataAnnotations;

namespace Optimizely_CMS.Models
{
    [ContentType(GUID = "72BCAD72-6D3A-41A4-820C-F27A91DDDC8C")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png,webp")]
    public class ImageFile : ImageData
    {
    }
}