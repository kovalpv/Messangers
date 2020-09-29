using System;
using System.Collections.Generic;
using Messengers.Exceptions;

namespace Messengers.Common {
    public class MessengerFactory {
        private Dictionary<string, Func<Identity, IMessenger>> registeredTypes;

        public MessengerFactory () {
            this.registeredTypes = new Dictionary<string, Func<Identity, IMessenger>> ();
        }

        public IMessenger GetMessenger (string messengerType, Identity identity) {
            if (this.registeredTypes.ContainsKey (messengerType)) {
                var creator = this.registeredTypes[messengerType];
                return creator (identity);
            }
            throw new UnregistredMessengerException (messengerType);
        }

        public void Registry (string name, Func<Identity, IMessenger> creator) {
            this.registeredTypes[name] = creator;
        }

    }
}