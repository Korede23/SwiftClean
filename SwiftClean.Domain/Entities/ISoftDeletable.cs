﻿namespace SwiftClean.Domain.Entities
{
    public interface ISoftDeletable
    {
        public bool IsDeleted { get; set; }
    }
}
