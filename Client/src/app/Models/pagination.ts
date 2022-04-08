export interface Pagination {
    currentPage: number;
    totalPages: number;
    pageSize: number;
    totalCount: number;
}

export class PaginatedResults<T> {
    result!: T;
    pagination!: Pagination;
}