﻿namespace TrainOrgApi.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public RoleIdDto RoleId { get; set; }
    }
}