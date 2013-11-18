﻿namespace Client.Tests.Mocks
{
    using Client.Common.Models.Subsonic;
    using Client.Common.Results;
    using global::Common.Mocks;

    public class MockGetAllPlaylistsResult : MockServiceResultBase<PlaylistCollection>, IGetAllPlaylistsResult
    {
    }
}