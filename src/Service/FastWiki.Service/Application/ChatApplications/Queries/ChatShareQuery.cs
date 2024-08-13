﻿namespace FastWiki.Service.Application.ChatApplications.Queries;

public record ChatShareQuery(string chatApplicationId, int page, int pageSize, Guid userId)
    : Query<PaginatedListBase<ChatShareDto>>
{
    public override PaginatedListBase<ChatShareDto> Result { get; set; }
}