using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance.human.Ukraine
{
    class UkrainianHuman : IEuropeansHuman, IHumanGeneral
    {
        DateTime _bornDate;
        long _idNumber;
        string _passportId, _skinColor;
        Object _father, _mather, _brather, _sister;

        public UkrainianHuman()
        {
            string _name;
            string _secondName;
            string _surName;
            long _idNumber;
            string _idCardSerial;

        }

        DateTime IHumanGeneral.BornDate
        {
            get
            {
                return _bornDate;
            }
            set
            {
                _bornDate = value;
            }
        }
        long IHumanGeneral.IdNumber
        {
            get
            {
                return _idNumber;
            }
            set
            {
                _idNumber = value;
            }
        }
        string IHumanGeneral.PassportId
        {
            get
            {
                return _passportId;
            }
            set
            {
                _passportId = value;
            }
        }
        object IHumanGeneral.Father
        {
            get
            {
                return _father;
            }
            set
            {
                _father = value;
            }
        }
        object IHumanGeneral.Mather
        {
            get
            {
                return _mather;
            }
            set
            {
                _mather = value;
            }
        }
        object IHumanGeneral.Sister
        {
            get
            {
                return _sister;
            }
            set
            {
                _sister = value;
            }
        }
        object IHumanGeneral.Brother
        {
            get
            {
                return _brather;
            }
            set
            {
                _brather = value;
            }
        }
        
        string IEuropeansHuman.SkinColor
        {
            get
            {
                return _skinColor;
            }
            set
            {
                _skinColor = value;
            }
        }
        
        public void Love()
        {
            Console.WriteLine("Human have some love...");
        }
        public struct Address
        {
            string Country;
            string Region;
            string City;
            string Street;
            int NumberHous;
            int NumberApartment;
        }
    }
}
