using BackendlessAPI.Test.PersistenceService.Entities.BaseEntities;

namespace BackendlessAPI.Test.PersistenceService.Entities
{
  public class WPPerson : CreatedEntity
  {
    public int Age { get; set; }
    public string Name { get; set; }

    protected bool Equals(WPPerson other)
    {
      return Age == other.Age && string.Equals( Name, other.Name );
    }

    public override bool Equals( object obj )
    {
      if( ReferenceEquals( null, obj ) )
        return false;
      if( ReferenceEquals( this, obj ) )
        return true;
      if( obj.GetType() != this.GetType() )
        return false;
      return Equals((WPPerson)obj);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (Age*397) ^ (Name != null ? Name.GetHashCode() : 0);
      }
    }
  }
}