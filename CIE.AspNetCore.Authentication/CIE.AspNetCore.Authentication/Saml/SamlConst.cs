﻿namespace CIE.AspNetCore.Authentication.Saml
{
    internal class SamlConst
    {
        public const string IdPName = nameof(IdPName);
        public const string SamlAuthnRequestId = nameof(SamlAuthnRequestId);
        public const string SubjectNameId = nameof(SubjectNameId);
        public const string SamlLogoutRequestId = nameof(SamlLogoutRequestId);
        public const string AuthnStatementSessionIndex = nameof(AuthnStatementSessionIndex);
        public const string SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
        public const string DigestMethod = "http://www.w3.org/2001/04/xmlenc#sha256";

        public static string Version = "2.0";
        public static string Success = "urn:oasis:names:tc:SAML:2.0:status:Success";
        public static string IssuerFormat = "urn:oasis:names:tc:SAML:2.0:nameid-format:entity";
        public static string ProtocolBinding = "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST";
        public static string NameIDPolicyFormat = "urn:oasis:names:tc:SAML:2.0:nameid-format:transient";
        public static string Saml2pProtocol = "urn:oasis:names:tc:SAML:2.0:protocol";
        public static string LogoutUserProtocol = "urn:oasis:names:tc:SAML:2.0:logout:user";
        public static string samlp = nameof(samlp);
        public static string saml = nameof(saml);
        public static string Saml2Assertion = "urn:oasis:names:tc:SAML:2.0:assertion";
        public static string SpidL = "https://www.spid.gov.it/SpidL";
        public static string Method = "urn:oasis:names:tc:SAML:2.0:cm:bearer";
        public static string name = nameof(name);
        public static string familyName = nameof(familyName);
        public static string fiscalNumber = nameof(fiscalNumber);
        public static string dateOfBirth = nameof(dateOfBirth);

    }
}
