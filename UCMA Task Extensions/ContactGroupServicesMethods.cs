using System.Threading.Tasks;
using Microsoft.Rtc.Collaboration.ContactsGroups;

namespace LyncAsyncExtensionMethods
{
    public static class ContactGroupServicesMethods
    {
        public static Task AddContactAsync(this 
            ContactGroupServices cgs, string contactUri)
        {
            return Task.Factory.FromAsync(
                cgs.BeginAddContact, cgs.EndAddContact,
                contactUri, null);
        }

        public static Task AddContactAsync(this 
            ContactGroupServices cgs, string contactUri,
            ContactAddOptions options)
        {
            return Task.Factory.FromAsync(
                cgs.BeginAddContact, cgs.EndAddContact,
                contactUri, options, null);
        }

        public static Task AddGroupAsync(this 
            ContactGroupServices cgs, string groupName,
            string groupData)
        {
            return Task.Factory.FromAsync(
                cgs.BeginAddGroup, cgs.EndAddGroup,
                groupName, groupData, null);
        }

        public static Task DeleteContactAsync(this 
            ContactGroupServices cgs, string contactUri)
        {
            return Task.Factory.FromAsync(
                cgs.BeginDeleteContact, cgs.EndDeleteContact,
                contactUri, null);
        }

        public static Task DeleteGroupAsync(this 
            ContactGroupServices cgs, int groupId)
        {
            return Task.Factory.FromAsync(
                cgs.BeginDeleteGroup, cgs.EndDeleteGroup, groupId, null);
        }

        public static Task<Contact> GetCachedContactAsync(this 
            ContactGroupServices cgs, string contactUri)
        {
            return Task<Contact>.Factory.FromAsync(
                cgs.BeginGetCachedContact, cgs.EndGetCachedContact,
                contactUri, null);
        }

        public static Task<Group> GetCachedGroupAsync(this 
            ContactGroupServices cgs, int groupId)
        {
            return Task<Group>.Factory.FromAsync(
                cgs.BeginGetCachedGroup, 
                cgs.EndGetCachedGroup, groupId, null);
        }

        public static Task UpdateContactAsync(this 
            ContactGroupServices cgs, Contact contact)
        {
            return Task.Factory.FromAsync(
                cgs.BeginUpdateContact, cgs.EndUpdateContact,
                contact, null);
        }

        public static Task UpdateGroupAsync(this 
            ContactGroupServices cgs, Group group)
        {
            return Task.Factory.FromAsync(
                cgs.BeginUpdateGroup, cgs.EndUpdateGroup, 
                group, null);
        }
    }
}
