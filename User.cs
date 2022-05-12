using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kurs_Interfeces
{
    public class User
    {
        public string fio;
        public string login;
        private Int32 hash_pass;
        private string salt; //для большей безопасности пароля
        public int access_level; //0 - просмотр, 1 - добавление/удаление/редактирование светофоров, 2 - свободно менять состояние светофоров, добавлять пользователей
        public bool active = false;
        public User(string inp_fio, string inp_login, string inp_pass, int inp_access = 0)
        {
            fio = inp_fio;
            login = inp_login;
            salt = RandomString(8);
            hash_pass = get_hash(inp_pass);
            access_level = inp_access;
        }
        public User(string inp_fio, string inp_login, string inp_salt, Int32 inp_pass, int inp_access)
        {
            fio = inp_fio;
            login = inp_login;
            salt = inp_salt;
            hash_pass = inp_pass;
            access_level = inp_access;
        }
        public Int32 get_hash(string inp)
        {
            return (inp + salt).GetHashCode();
        }
        private string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public bool Validate(string inp_login, Int32 inp_pass)
        {
            return (inp_login == login) && (inp_pass == hash_pass);
        }
        public void saveToFile(StreamWriter sw)
        {
            sw.WriteLine(fio);
            sw.WriteLine(login);
            sw.WriteLine(salt);
            sw.WriteLine(hash_pass);
            sw.WriteLine(access_level);
        }
    }
}
