using System;
using _02350_FinalProject.Model;
using _02350_FinalProject.ViewModel.Objects;

namespace _02350_FinalProject.ViewModel.Connections
{
    public abstract class ConnectionViewModel : BaseViewModel, IConnection
    {
        private ObjectViewModel _to;
        private ObjectViewModel _from;
        private readonly Connection _connection;
        public int FromNumber => _from.Number;
        public string Label { get; set; }
        public int ToNumber => _to.Number;
        public EConnection Type { get; set; }

        protected ConnectionViewModel(Connection connection)
        {
            _connection = connection;
        }
        protected ConnectionViewModel(Connection connection, ObjectViewModel from, ObjectViewModel to) : this(connection)
        {
            To = to;
            From = from;
        }
        public string FromMultiplicity
        {
            get { return _connection.FromMultiplicity; }
            set
            {
                _connection.FromMultiplicity = value;
            }
        }


        public string ToMultiplicity
        {
            get { return _connection.FromMultiplicity; }
            set
            {
                _connection.ToMultiplicity = value;
            }
        }

        public ObjectViewModel To
        {
            get { return _to; }
            set
            {
                _to = value;
                _connection.ToNumber = value.Number;

            }
        }

        public ObjectViewModel From
        {
            get { return _from; }
            set
            {
                _from = value;
                _connection.FromNumber = value.Number;

            }

        }
    }
}
