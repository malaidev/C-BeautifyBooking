﻿namespace BeautyBooking.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBlogPostsService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByTitle<T>(string title);

        T GetById<T>(int id);

        Task AddBlogPostAsync(string title, string content, string author, string imageUrl);

        Task DeleteBlogPostAsync(int id);
    }
}
