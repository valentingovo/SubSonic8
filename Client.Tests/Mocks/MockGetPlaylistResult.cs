﻿namespace Client.Tests.Mocks
{
    using Client.Common.Models.Subsonic;
    using Client.Common.Results;
    using global::Common.Mocks;

    public class MockGetPlaylistResult : MockServiceResultBase<Playlist>, IGetPlaylistResult
    {
        #region Public Properties

        public int Id { get; private set; }

        #endregion
    }
}