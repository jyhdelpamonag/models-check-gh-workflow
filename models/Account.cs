public class Account {
    public int AccountId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public DateTime? CreatedAtRenamed { get; set; }
    public bool IsActive { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? LastLogin { get; set; }
}