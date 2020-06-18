﻿using Entities.ExtendedModels;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(Guid ownerId);

        Owner GetOwnerByEmail(string email);

        Owner GetOwnerByRefreshToken(string refreshToken);

        OwnerExtended GetOwnerWithDetails(Guid ownerId);
        
        void CreateOwner(Owner owner);        
        void UpdateOwner(Owner dbOwner, Owner owner);
        void DeleteOwner(Owner owner);
    }
}
