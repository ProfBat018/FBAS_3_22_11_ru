namespace ProductData.DTO;

public record PaginatedProductViewModel(
    List<ProductViewModel> items,
    int totalCount,
    int pageNumber,
    int pageSize,
    int totalPages,
    bool hasPrevious,
    bool hasNext);
    