﻿using System.Collections.Generic;
using AltV.Net.Elements.Args;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Net.Elements.Entities;

public interface IVirtualEntity : ISharedVirtualEntity, IWorldObject
{
    void SetStreamSyncedMetaData(string key, object value);
    void SetStreamSyncedMetaData(Dictionary<string, object> metaData);
    void SetStreamSyncedMetaData(string key, in MValueConst value);
    void DeleteStreamSyncedMetaData(string key);
}