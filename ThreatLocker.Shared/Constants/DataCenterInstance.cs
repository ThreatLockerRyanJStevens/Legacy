using System;
using System.Collections.Generic;
using System.Linq;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Shared.Constants
{
    public class DataCenterInstance
    {
        public static readonly DataCenterInstance DEV = new DataCenterInstance("A42FD2EB-3749-4F37-8688-C9236C79A876".ToSafeGuid(), "A",
            "f8UEL2WNrhjFSKYntmaqtG7Q9bz6JrYa76CbuhvY98YMrLZYyyk2vaUzH2EBWuMNHUq9bNFiekqh8bDPXMwtdBbdMRZ4qhDbKTSP66iypgjzkZPXYyTryw66dqGAebQXgcRvTHUYTkbfQEhF7fSUrU");

        public static readonly DataCenterInstance TEST = new DataCenterInstance("0BCE57BE-4090-46F4-877D-858DCB27D570".ToSafeGuid(), "TEST",
           "f8UEL2WNrhjFSKYntmaqtG7Q9bz6JrYa76CbuhvY98YMrLZYyyk2vaUzH2EBWuMNHUq9bNFiekqh8bDPXMwtdBbdMRZ4qhDbKTSP66iypgjzkZPXYyTryw66dqGAebQXgcRvTHUYTkbfQEhF7fSUrU");

        public static readonly DataCenterInstance A = new DataCenterInstance("A42FD2EB-3749-4F37-8688-C9236C79A876".ToSafeGuid(), "A",
           "0LxmAjIg5x3do648076MD38D6Ewn4S10W5Gx88xgytj0r3ADkr7eB91i2wEa92dLs8vTY6Bx3SzJe2ZXlxjWOVY4v8GeM6w3eD8vELRtYi2MZE0SX4HYg62LosyTXzq3e0190p5S29RxfmBP41QPzG");

        public static readonly DataCenterInstance B = new DataCenterInstance("628CCE3B-0E0F-4272-AF86-58FBF1FA5764".ToSafeGuid(), "B",
            "J9iYhI69aa8qVe8HohiDxbZsX8SIRDO7O8H10R2MPh3H9XS1rqgXRMsjlaRrhDn114ayPSh3g686102G505PawklO38B0Z3hN891bNrNfz434LrTmV101radaMQ602rbw4vN7660P7YstjDERHWVr3");
        
        public static readonly DataCenterInstance C = new DataCenterInstance("D49093E8-7458-4223-A982-47BC4FD610E2".ToSafeGuid(), "C",
            "91H44O561e29V233f35i330Twv2E0Z7B9imYx9HRifdFgTqx24VJLQyIA3HyjMSM3A7tJdVv0tQX2hrr9w6f41frs65Eoy2NgdF4Afg0n5YVzHlbJ7KW743KBm0NEgs4Ny8WhI70pIotPaYqN32DdB");

        public static readonly DataCenterInstance D = new DataCenterInstance("DA41A773-06F2-48C0-8E68-A5C6C5D05A5B".ToSafeGuid(), "D",
            "kDxSJHr5sH0zVqnp468Ov1J6ZeN4h3o4x3KaPGDF3KJS9mI8tHmF3Nt3G4gshSPYh5t09LGW6inI1n3Ktt8eIjL8VSJz30F8b70l7eH286hyW345h40lfn8A76KddDHPmKjb85rDk06743FmNa4TwZ");

        public static readonly DataCenterInstance E = new DataCenterInstance("3C2BE9E7-59CF-4FBD-BD7B-2AA73D102415".ToSafeGuid(), "E",
            "JrB42I8VQNmKP02MrN88WmRLJ16KnzbBkzndp8ikO098f1kfFv3m91v2ye14971raSR1f4bJhjFZd6AQrg2yb0922D3r5T20EJI53WWTL3450s1Bq2HO8ayN4TKdSkPlLvR7nXHVM7ne9tjF3Pds1l");

        public static readonly DataCenterInstance F = new DataCenterInstance("F58CAF82-83B4-41E0-BDC0-DE0911EAA34C".ToSafeGuid(), "F",
            "wslRBl3MagbTrS80MnE5GmrX5Q8b78xIer36jQmB3zk6Ta1618qVsd1nWf0FopypYjGHWAviX9iO40R5L7GsQ12Yp85K0Z0j48Y606W1h3BZ3dJbWEPlzv4NR1Hl3q62mkVD83F0D0n9dHYF433pLw");

        public static readonly DataCenterInstance G = new DataCenterInstance("D3708B0D-9705-484A-AF4B-6E59D903472A".ToSafeGuid(), "G",
            "zhwS96ype1s1VIy5JsGm5AE42bs9Bj6jWI7W2V85L34RX2A2iPQB0iRBBwVX9Amb07sl0XlqfNK1EsP320zeNE43SNqJ6PH5mq6a8xdVva0Kb1D23j7wJh1DNf4844K3gzA4Tlk3Q4Afok9qp22JpM");

        public static readonly DataCenterInstance H = new DataCenterInstance("EBCABF52-B67A-4F4C-A78F-963831C739A4".ToSafeGuid(), "H",
            "18x3r0r1fpsrtgd0ujpjhxcuc7wz6dju8nfqt3lxpwogkxg06462agy763ok1mpybqqgokkdkgf9gkv74h46j1pz6afr98zj1jcup7g9dl3ifo8eorl0dmqk8exfa6924wwv8zmnyycxgcp5keyc8w");

        public static readonly DataCenterInstance AE1 = new DataCenterInstance("73ab199d-b783-4bfe-b5c3-d786202375ce".ToSafeGuid(), "AE1",
            "okmy1ai8tkwt3v7dn54agfztru6pvvek27xj5jmbx861wvx0ds8dsmlrfbt5f8yot7if9fcnuhjkwprrigrbjrzdu6i9tbelkci6cemlx2vn1b8hs3hjn7dgkrh9qpln8kf7mkiz4i5zx0lda3efu0");

        public static readonly DataCenterInstance AU1 = new DataCenterInstance("9cc969ce-a35e-407d-b8f3-926a30f424e2".ToSafeGuid(), "AU1",
            "DzOe40g6o7s3Wl8HCoSIpHbOCXgkoRbdjemxt62kVqdmVVTGTMbPtQFsymB7aq3NDP7vW4Kk46fksLaPT8oA2BHq3Nli9TmfUWJBwQEeIoB9F1EHja8FvU40tTp28RitRwLDoR5etGSmfxL5Vl89Rq");

        public static readonly DataCenterInstance EU1 = new DataCenterInstance("0b806eca-3d64-478d-8f44-1e002ede6743".ToSafeGuid(), "EU1",
            "tfwCIfCscLV3ujZnFh17OQPmdOMlIHIx1mzWPhyGXcKJQRCELM8nsu1F0RAfSx3LNfzI3AiIiH1uoWLxreECn8gCHW3GyHqrhJDyktPPoap6aaPrrOkmcbJ6pWtugw2WBRMJLsPXHbKS8Yki4l1a6T");

        public static readonly DataCenterInstance CA1 = new DataCenterInstance("1E3E14D6-06E8-4154-8243-B0AF049C8AAE".ToSafeGuid(), "CA1",
            "gxiwfi8qsn5d2pbv361a7c8bgfdtu0lk6tn6wa3514x1muvz43mn8pk6cw4fs6t38ewrtz6d6ohspqd0rnzrbzvlrzzao3n8ocpq20y1si1ti1ie0ho763d90elnisw9n7uosdsebyzhagq2uvay8r");

        public DataCenterInstance(Guid id, string instanceName, string authenticationKey)
        {
            Id = id;
            InstanceName = instanceName;
            AuthenticationKey = authenticationKey;
        }

        public Guid Id { get; set; }
        public string InstanceName { get; set; }
        public string AuthenticationKey { get; set; }

        public static readonly DataCenterInstance[] All =
        {
            DEV,
            TEST,
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
            AE1,
            AU1,
            EU1,
            CA1
        };

        public static DataCenterInstance Find(Guid id)
        {
            return All.FirstOrDefault(x => x.Id.ToSafeGuid() == id.ToSafeGuid());
        }

        public static DataCenterInstance FindByInstanceName(string instanceName)
        {
            return All.FirstOrDefault(x => x.InstanceName == instanceName);
        }

        public static List<DataCenterInstance> FindByAuthenticationKey(string authenticationKey)
        {
            return All.Where(w => w.AuthenticationKey == authenticationKey).ToList();
        }
    }
}
